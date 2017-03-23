using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Linq.Expressions;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;

namespace ModelMVPDataBasePart
{
    public interface IDataBaseOperation
    {
        bool CreateConnection(string Login, string Pass, byte TypeOfConnection);
        bool TestConnection();
        void AddEvent(string EventName);
        void AddEventsFromEventCreator(List<EventDateCreator> InList);
    }

    public class DataBaseOperationClass:IDataBaseOperation
    {
        public static SqlConnection Connect { get; private set; }
        public static ArcheageDataBaseEntities DataBaseECont { get; private set; }
        private static DbSet<EventBase> EventTable { get; set; }
        private static DbSet<EventTimeTable> EventTimeTable { get; set; }


        //private Func<ArcheageDataBaseEntities, string, DateTime, bool> ContainsData = CompiledQuery.Compile<ArcheageDataBaseEntities,string, DateTime, bool>((MyB, InName, InData) => (MyB.EventTimeTable.Any(n => (n.EventBase.EventName == InName && n.EventDateTime == InData))));
        //private Func<ArcheageDataBaseEntities, string, IEnumerable<EventDateCreator>, bool> Compl = CompiledQuery.Compile<ArcheageDataBaseEntities, string, IEnumerable<EventDateCreator>, IEnumerable<bool>>((Myb, InName, InEnum) => (Myb.EventTimeTable.Any(n => (n.EventBase.EventName == InName && n.EventDateTime == InEnum.First().EventDate))) );



        public DataBaseOperationClass()
        {
            Connect = new SqlConnection();
        }

        public bool CreateConnection(string Login, string Pass, byte TypeOfConnection)
        {
            switch (TypeOfConnection)
            {
                case 1:
                    Connect = new SqlConnection("Server=95.31.27.196,6702\\SQL Server;Initial Catalog=ArcheageDataBase;User ID=" + Login + ";Password=" + Pass + ";");
                    break;
                case 2:
                    Connect = new SqlConnection("Data Source=DESKTOP-I53NOBN;Initial Catalog=ArcheageDataBase;Integrated Security=True;Persist Security Info=True;User ID=" + Login + ";Password=" + Pass + ";");
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
            try
            {
                Connect.Open();
                Connect.Close();
                return true;
            }
            catch { return false; }
        }

        public void AddEventsFromEventCreator(List<EventDateCreator>Inlist)
        {
            Connect.Open();
            DataBaseECont.EventBase.Add(new EventBase { EventName = Inlist.First().EventName, EventTimeTable = CollectionFromEventDateCreator(Inlist)}); //ВЫбрать между этим или Foreach ниже
            foreach(EventDateCreator DT in Inlist)
            {
                DataBaseECont.EventTimeTable.Add(new EventTimeTable { EventDateTime = DT.EventDate, EventID = DataBaseECont.EventBase.Local.Last().EventID, UserID = (short)DataBaseECont.GetNowUserID().FirstOrDefault(), EverywhatRemind = DT.RemindEvery });
            }
            DataBaseECont.SaveChanges();
            Connect.Close();
        }

        private ICollection<EventTimeTable> CollectionFromEventDateCreator(List<EventDateCreator> InList)
        {
            List<EventTimeTable> Result = new List<EventTimeTable>();
            foreach(EventDateCreator DT in InList)
            {
                Result.Add(new EventTimeTable { EventDateTime = DT.EventDate, UserID = (short)DataBaseECont.GetNowUserID().FirstOrDefault(), EverywhatRemind = DT.RemindEvery });
            }
            return Result;
        }

        public void AddEvent(string EventNam)
        {
            Connect.Open();
            DataBaseECont.EventBase.Add(new EventBase { EventName = EventNam });
            DataBaseECont.SaveChanges();
            Connect.Close();
        }

        public void AddReminder()
        {
            Connect.Open();
        }

        public static void GetTypeOfConnection()
        {

        }

        

        private bool CheckDataForEventAdding(string InName, IEnumerable<EventDateCreator> InBaseDatas)
        {
            foreach (EventDateCreator T in InBaseDatas)
            {
                if (DataBaseECont.EventTimeTable.Any(n => (n.EventBase.EventName == InName) && (n.EventDateTime == T.EventDate)))
                    return false;           
            }
            return true;
        }
    }
}
