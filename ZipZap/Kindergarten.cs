using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZipZap
{
    internal class Kindergarten
    {
        List<Observer> benachrichtigbare;

        public Kindergarten()
        {
            benachrichtigbare = new List<Observer>();
        }
        public void elternHinzufügen(Observer benachrichtigbareakt)
        {
            benachrichtigbare.Add(benachrichtigbareakt);
        }
        public void elternLöschen(Observer benachrichtigbareakt)
        {
            benachrichtigbare.Remove(benachrichtigbareakt);
        }
        public void alamieren()
        {
            foreach (Observer item in benachrichtigbare)
            {
                item.Observe();
            }//
        }
    }
}
