using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebTest.Model
{
    public class Product
    {

        [Key]
        public string Id { get; set; }


        public string Name { get; set; }



        public string Address { get; set; }



        public string Weight { get; set; }



        public string Height { get; set; }



    }
}
