﻿using DAMComponentLibrary.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DAMComponentLibrary.Events
{
    public class SelectUIElementEventArgs : RoutedEventArgs
    {
        public int Col { get; internal set; } 
        public int Row { get; internal set; }
        public MatrixCell? Cell { get; internal set;}

    }

}