using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HocKteam
{
    class Person
    {
        private string name;
        private int toan;
        private int van;
        public string Name
        {
            set
            {
                this.name = value;
            }
            get
            {
                return this.name;
            }
        }
        public int Toan
        {
            set { this.Toan = value; }
            get { return this.toan; }
        }
        public int Van
        {
            set { this.van = value; }
            get { return this.toan; }
        }
    }
}
