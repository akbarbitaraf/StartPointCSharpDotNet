using LinqToExcel;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeginingLinq
{
    class ConnectionExcel
    {
        private string path;
        private ExcelQueryFactory conections;
        public string Path {
            get
            {
                return path; 
            }
            set
            {
                path = value;
            }    
           }
        public ExcelQueryFactory Connections {
            get {

                return conections; 
            }
            set
            {
                conections = value; 

            }
        
        }
        public ConnectionExcel(string path)
        {
            this.path = path;
            conections = new ExcelQueryFactory(this.path);

        }

    }
}
