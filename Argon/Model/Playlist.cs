using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Argon.Model
{
    class Playlist
    {
        private string name;
        private string path;
        private string extensionless_name;

        public string Extensionless_name
        {
            get { return this.extensionless_name; }
            set { this.extensionless_name = value; }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string Path
        {
            get { return this.path; }
            set { this.path = value; }
        }
    }
}
