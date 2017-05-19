using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Linq.Expressions;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using ModelMVPDataBasePart.Common;
using System.Data.Common;
using ModelMVPDataBasePart;

namespace ModelMVPDataBasePart
{

    public interface IDataConnection
    {
        bool CreateConnection(string Login, string Pass, byte TypeOfConnection);
        bool TestConnection();

    }

    public interface IMainFormData:IDataConnection
    {
        object GetBaseView();
    }

    public interface IDataRemindAdding:IDataConnection
    {
        bool AddRemindsFromRemindCreator(List<RemindDataCreator> InList, int EventID);
        string[] GetEventNamesArray();
        List<EventTimeTable> GetItemsForFormInitialize(int InID);
    }

    public interface IDataEventAdding:IDataConnection
    {
        void AddEvent(string EventName);
        bool AddEventsFromEventCreator(List<EventDataCreator> InList);
    }

    public interface IDataMainMenuFunctional:IDataConnection
    {
        IEnumerable<EventDataCreator> SelectAllAsDataCreator();
    }

    public abstract class BaseDBClass
    {
        public static ArchEntityFramework DataBaseECont { get; protected set; }
        
    }

    public class DataBaseOperationClass:BaseDBClass,IDataEventAdding,IDataRemindAdding,IDataMainMenuFunctional,IMainFormData
    {
        private int NowUserID;
        //private Func<ArcheageDataBaseEntities, string, DateTime, bool> ContainsData = CompiledQuery.Compile<ArcheageDataBaseEntities,string, DateTime, bool>((MyB, InName, InData) => (MyB.EventTimeTable.Any(n => (n.EventBase.EventName == InName && n.EventDateTime == InData))));
        //private Func<ArcheageDataBaseEntities, string, IEnumerable<EventDateCreator>, bool> Compl = CompiledQuery.Compile<ArcheageDataBaseEntities, string, IEnumerable<EventDateCreator>, IEnumerable<bool>>((Myb, InName, InEnum) => (Myb.EventTimeTable.Any(n => (n.EventBase.EventName == InName && n.EventDateTime == InEnum.First().EventDate))) );
        public DataBaseOperationClass()
        {

        }
        #region IDataConnection Implementation
        public bool CreateConnection(string Login, string Pass, byte TypeOfConnection)
        {
            DataBaseECont = new ArchEntityFramework();
            switch (TypeOfConnection)
            {
                case 1:
                    //DataBaseECont.Database.Connection.ConnectionString = "Server=95.31.27.196,6702\\SQL Server;Initial Catalog=ArcheageDataBase;User ID=" + Login + ";Password=" + Pass + ";";
                    break;
                case 2:
                    //DataBaseECont.Database.Connection.ConnectionString = "Data Source=localhost;Initial Catalog=ArcheageDataBase;Integrated Security=True;Persist Security Info=True;User ID=" + Login + ";Password=" + Pass + ";";
                    break;
            }
            if (TestConnection())
            {
                //DataBase = new DataContext(Connect.ConnectionString);
                return true;
            }
            else return false;
        }

        public bool TestConnection()
        {
            if(DataBaseECont.Database.Exists())
            {
                try
                {
                    DataBaseECont.Database.Connection.Open();
                    DataBaseECont.Database.Connection.Close();
                    return true;
                }
                catch { return false; }
            }
            return false;
        }

        #endregion

        #region IDataEventAdding Implementation
        public bool AddEventsFromEventCreator(List<EventDataCreator>Inlist)
        {
            try
            {
                DataBaseECont.Database.Connection.Open();
                DataBaseECont.EventBase.Add(new EventBase { EventName = Inlist.First().EventName, EventTimeTable = CollectionFromEventDateCreator(Inlist) }); //ВЫбрать между этим или Foreach ниже
                foreach (EventDataCreator DT in Inlist)
                {
                    DataBaseECont.EventTimeTable.Add(new EventTimeTable
                    {
                        EventDateTime = DT.EventDate,
                        EventID = DataBaseECont.EventBase.Local.Last().EventID,
                        UserID = (short)DataBaseECont.GetNowUserID(),
                        EverywhatRemind = DT.RemindEvery });
                }
                DataBaseECont.SaveChanges();
                DataBaseECont.Database.Connection.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void AddEvent(string EventNam)
        {
            DataBaseECont.EventBase.Add(new EventBase { EventName = EventNam });
            DataBaseECont.SaveChanges();
        }

        private ICollection<EventTimeTable> CollectionFromEventDateCreator(List<EventDataCreator> InList)
        {
            List<EventTimeTable> Result = new List<EventTimeTable>();
            foreach (EventDataCreator DT in InList)
            {
                Result.Add(new EventTimeTable {
                    EventDateTime = DT.EventDate,
                    UserID = (short)DataBaseECont.GetNowUserID(),
                    EverywhatRemind = DT.RemindEvery });
            }
            return Result;
        }
        #endregion

        #region IDataRemindAdding Implementation
        public bool AddRemindsFromRemindCreator(List<RemindDataCreator> InList, int InID)
        {
            try
            {
                DataBaseECont.Database.Connection.Open();
                foreach (RemindDataCreator DT in InList)
                {
                    DataBaseECont.EventRemindTable.Add(new EventRemindTable
                    {
                        EventID = InID,
                        DateUntilRemind = DT.RemindUntil,
                        UserID=(short)DataBaseECont.GetNowUserID(),
                        TypeOfRemind = DT.HowToRemind,
                        //TODO
                    });   
                }
                DataBaseECont.SaveChanges();
                DataBaseECont.Database.Connection.Close();
                return true;
            }
            catch { return false; }
        }

        public string[] GetEventNamesArray()
        {
            int temp = DataBaseECont.GetNowUserID();
            return DataBaseECont.EventTimeTable.Where(W => (W.UserID ==0 || W.UserID==temp))
                .Select(P => P.EventBase.EventName)
                .Distinct()
                .ToArray();
        }

        public List<EventTimeTable> GetItemsForFormInitialize(int InID)
        {
            return DataBaseECont.EventTimeTable.Where(W => (W.EventID == InID && W.UserID == NowUserID))
                .ToList();

        }

        #endregion

        #region IDataMainMenuFunctional Implementation

        public IEnumerable<EventDataCreator> SelectAllAsDataCreator()  //TODO
        {
            IEnumerable<EventTimeTable> TempDataSelector;
            return new List<EventDataCreator>();

        }
        #endregion

        #region IMainData Implementation
        public object GetBaseView()
        {
            var t=DataBaseECont.GetViewForNowUser().ToList();
            List<MainViewShowClass> ReturnList = new List<MainViewShowClass>();
            foreach (var el in t)
            {
                ReturnList.Add(new MainViewShowClass(el));
            }
            return ReturnList;
        }
        #endregion
        public static void GetTypeOfConnection()
        {

        }

        

        //private bool CheckDataForEventAdding(string InName, IEnumerable<EventDateCreator> InBaseDatas)
        //{
        //    foreach (EventDateCreator T in InBaseDatas)
        //    {
        //        if (DataBaseECont.EventTimeTable.Any(n => (n.EventBase.EventName == InName) && (n.EventDateTime == T.EventDate)))
        //            return false;           
        //    }
        //    return true;
        //}
    }
}
