using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AgendaAmigo
{
    internal class Amigo
    {
        private string name, correo;
        private long id, tel;

        public Amigo()
        {
            name = "";
            correo = "";
            id = 0;
            tel = 0;
        }
        public Amigo(string name, string correo, long id, long tel)
        {
            this.name = name;
            this.correo = correo;
            this.id = id;
            this.tel = tel;
        }

        public string Name
        {
            get{return name;}
            set{name = value;}
        }
        public string Correo
        {
            get{ return correo;}
            set{ correo = ""; }
        }
        public long Id
        {
            get{return id;}
            set{ id = 0;}
        }
        public long Tel
        {
            get{return tel;}
            set{id = 0;}
        }
    }
    
}
