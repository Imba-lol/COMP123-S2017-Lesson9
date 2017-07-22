﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/* 
 * Abubakir Myrzaly
 * Date: July 11,2017
 * Description: This is the SuperHuman class that extends the Human abstract class
 * Version: 0.2 - Added _initialize method
 */

namespace COMP123_S2017_Lesson9
{
    /// <summary>
    /// This is the SuperHuman class.
    /// </summary>
    public class SuperHuman : Human
    {
        // PRIVATE INSTANCE VARIABLES

        private List<Power> _powers;

        // PUBLIC PROPERTIES

        public List<Power> Powers
        {
            get
            {
                return this._powers; // this returns a reference
            }
        }
        // CONSTRUCTORS -----------------

        /// <summary>
        /// This is main constructor for the SuperHuman class.
        /// It takes one parameter - name (string)
        /// </summary>
        /// <param name="name"></param>
        public SuperHuman(string name)
            :base(name)
        {
            this._initialize();
        }

        // PRIVATE METHODS

        /// <summary>
        /// This method initializes, instantiates and assigns value to class properties
        /// </summary>
        private void _initialize()
        {
            this._powers = new List<Power>(); // creates an empty list
        }

        // PUBLIC METHODS
    }
}