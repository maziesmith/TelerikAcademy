﻿using AcademyEcoSystemMySolution.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyEcoSystemMySolution.Classes
{
    public abstract class Organism : IOrganism
    {
        public bool IsAlive { get; protected set; }

        public Point Location { get; protected set; }

        public int Size { get; protected set; }

        public Organism(Point location, int size)
        {
            this.Location = location;
            this.Size = size;
            this.IsAlive = true;
        }

        public virtual void Update(int time)
        {
        }

        public virtual void RespondTo(IOrganism organism)
        {
        }

        public override string ToString()
        {
            return this.GetType().Name;
        }
    }
}
