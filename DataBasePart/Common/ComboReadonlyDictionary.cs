using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBasePart.Common
{
    class ComboReadonlyDictionary
    {
        private Dictionary<string, TimeSpan> SourceDictionary;

        public ComboReadonlyDictionary(byte SetBaseDictionary)
        {
            SourceDictionary = new Dictionary<string, TimeSpan>();
            switch(SetBaseDictionary)
            {
                case 0:
                    InitializeBeforeCombo();
                    break;
                case 1:
                    InitializeAfterCombo();
                    break;
            }
        }

        public ICollection<string> Keys
        {
            get { return this.SourceDictionary.Keys; }
        }

        public ICollection<TimeSpan> Values
        {
            get { return this.SourceDictionary.Values; }
        }

        public void Clear()
        {
            SourceDictionary.Clear();
        }

        private void InitializeBeforeCombo()
        {
            this.SourceDictionary.Add("За 5 минут до", TimeSpan.FromMinutes(5));
            this.SourceDictionary.Add("За 10 минут до", TimeSpan.FromMinutes(10));
            this.SourceDictionary.Add("За 20 минут до", TimeSpan.FromMinutes(20));
            this.SourceDictionary.Add("За 30 минут до", TimeSpan.FromMinutes(30));
            this.SourceDictionary.Add("За час до", TimeSpan.FromHours(1));
        }

        private void InitializeAfterCombo()
        {
            this.SourceDictionary.Add("Через 5 минут", TimeSpan.FromMinutes(5));
            this.SourceDictionary.Add("Через 10 минут", TimeSpan.FromMinutes(10));
            this.SourceDictionary.Add("Через 20 минут", TimeSpan.FromMinutes(20));
            this.SourceDictionary.Add("Через 30 минут", TimeSpan.FromMinutes(30));
            this.SourceDictionary.Add("Через час", TimeSpan.FromHours(1));
        }
    }
}
