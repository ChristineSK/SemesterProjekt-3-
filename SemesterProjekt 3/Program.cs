﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using PresentationLayer;
using BusinessLayer;


namespace Semesterprojekt_3
{
    class Program
    {
        //GutHUb Test
<<<<<<< HEAD
        //Bjørn test
        // testets
=======
        //Bjørn test+lo

            //ll
>>>>>>> origin/master
        private PresentationLayer.ControlPresentationLayer currentSFPUI;
        private BusinessLayer.ControlBusinessLogic currentBL;
        private DataLayer.ControlDataLogic currentDL;


        static void Main(string[] args)
        {
            Program currentApp = new Program();
        }

        public Program()
        {
            //Dependensy injektion
            currentDL = new ControlDataLogic();
            currentBL = new ControlBusinessLogic(currentDL);
            currentSFPUI = new ControlPresentationLayer(currentBL);
            currentSFPUI.startUpGUI();
        }
    }
}