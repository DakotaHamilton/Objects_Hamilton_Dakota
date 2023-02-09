using System;
using System.Collections.Generic;
using System.Text;

namespace Objects_Hamilton_Dakota
{
    /// <summary>
    /// GETS IF THE THE COMPUTER IS ON OR OFF
    /// </summary>
    interface IBootUp
    {
       public bool IsOn { get; set; }

        public void PowerOnOff();

    }
}
