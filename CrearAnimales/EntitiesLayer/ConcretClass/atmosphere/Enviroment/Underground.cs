﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer.ConcretClass.atmosphere
{
    internal class Underground
    {

        private int id;
        private string _name;

        public int Id { get => id; set => id = value; }
        public string Name { get => _name; set => _name = value; }
    }
}