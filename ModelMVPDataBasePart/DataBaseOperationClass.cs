using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Linq;
using System.Data.Linq.SqlClient;
using System.Data.Linq.Mapping;
using System.Linq.Expressions;

namespace ModelMVPDataBasePart
{
    [Table(Name = "EventBase")]
    public class EventDB
    {
        [Column(IsPrimaryKey =true,IsDbGenerated =true,DbType ="Decimal(18,0) NOT NULL IDENTITY",Storage ="EventID")]
        private int EventID { get; set; }
        [Column(Name ="EventName",DbType ="NVarChar(50)", Storage ="EventID")]
        private string EventName { get; set; }
        [Association(Name = "FK_EventTimeTable_EventBase",Storage ="_ChildEventTimeObjects",ThisKey ="EventID", OtherKey ="EventID",DeleteRule ="CASCADE")]
        private EntitySet<EventTimeSubject> _ChildEventTimeObjects;
        public EventDB(string InName)
        {
            EventName = InName;
        }
    }

    [Table(Name ="EventTimeTable")]
    public class EventTimeSubject
    {
        [Column(IsPrimaryKey =true,Name ="EventID",DbType ="Decima(18,0) NOT NULL",Storage ="EventID")]
        private int EventID { get; set; }
        [Column(IsPrimaryKey =true,DbType = "SmallDateTime NOT NULL", Storage ="EventDateTime")]
        private DateTime EventDateTime { get; set; }
        [Column(DbType = "Decimal(10,0)", Storage = "HowLongToRemind")]
        private Nullable<int> HowLongToRemind { get; set; }
        [Column(DbType ="Time(0)",Storage ="RemindBefore")]
        private Nullable<TimeSpan> RemindBefore { get; set; }
        [Column(DbType ="Decimal(3,0)",Storage ="TypeOfRemind")]
        private Nullable<int> TypeOfRemind { get; set; }
        [Column(IsPrimaryKey =true,Storage ="UserID")]//Неизвестный тип юзера
        private int UserID { get; set; }
        [Column(DbType ="Time(0)",Storage ="EventDuration")]
        private Nullable<TimeSpan> EventDuration { get; set; }
        [Column(DbType ="Decima(1,0)",Storage ="EveryWhatRemind")]
        private Nullable<byte> EveryWhatRemind { get; set; }
        [Association(Name = "FK_EventTimeTable_EventBase", Storage = "_ParentEventDB", ThisKey = "EventID", OtherKey = "EventID", IsForeignKey = true, DeleteOnNull = true)]
        private EventDB _ParentEventDB { get; set; }

        public EventTimeSubject(DateTime DateTimeEvent, Nullable<int> HowLongToRem, Nullable<TimeSpan> RemindBef, Nullable<int>TypeOfRem, int UserD, Nullable<TimeSpan> EventDurat, Nullable<byte>EveryWhatRem)
        {
            EventDateTime = DateTimeEvent;
            HowLongToRemind = HowLongToRem;
            RemindBefore = RemindBef;
            TypeOfRemind = TypeOfRem;
            EventDuration = EventDurat;
            EveryWhatRemind = EveryWhatRem;
        }

        public void UpdateAnySubject(DateTime DateTimeEvent, Nullable<int> HowLongToRem, Nullable<TimeSpan> RemindBef, Nullable<int> TypeOfRem, int UserD, Nullable<TimeSpan> EventDurat, Nullable<byte> EveryWhatRem)
        {

        }
    }

    public class DataBaseOperationClass
    {
        public static SqlConnection Connect { get; private set; }
        public static DataContext DataBase { get; private set; }
        private Table<EventDB> EventTable { get; set; }
        private Table<EventTimeSubject> EventTimeTable { get; set; }
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
                DataBase = new DataContext(Connect.ConnectionString);
                return true;
            }
            else return false;
        }

        public static bool TestConnection()
        {
            try
            {
                Connect.Open();
                Connect.Close();
                return true;
            }
            catch { return false; }
        }

        public void AddEvent(string EventName, DateTime[] InDateTime)
        {
            Connect.Open();
            DataBase.GetTable<EventDB>().InsertOnSubmit(new EventDB(EventName));
            DataBase.SubmitChanges();
        }

        public static void GetTypeOfConnection()
        {

        }
    }
}
