﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_3___Library
{

    class Member
    {
        private int memberId;
        private string name;
        private string address;
        private int phone;

        //public properties

        public int MemberId
        {
            get { return memberId; }
            private set { memberId = value; } // Private setter makes it read-only
        }

        public string Name
        { get { return name; } 
          set { name = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public int Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        
        public Member(int memberId, string name, string address, int phone)
        {
            this.memberId = memberId;
            this.name = name;
            this.address = address;
            this.phone = phone;

        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Member Id: {memberId}");
            Console.WriteLine($"Member Name: {Name}");
            Console.WriteLine($"Member Address: {address}"); 
            Console.WriteLine($"Member Phone Number: {phone}");
            Console.WriteLine();
        }


    }
}
