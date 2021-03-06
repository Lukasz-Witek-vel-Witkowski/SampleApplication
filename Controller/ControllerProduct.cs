﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApplication.Controller
{
    class ControllerProduct
    {
        private static ControllerProduct instance;

        public delegate void ModelChangeDelegate(object sender, ModelChangeEventArgs e);
        public event ModelChangeDelegate ModelChangeEvent;
        public static ControllerProduct Instance()
        {
            if (instance == null)
                instance = new ControllerProduct();
            return instance;
        }
        public void RegisterView( IView view )
        {
            this.ModelChangeEvent += new ModelChangeDelegate( view.ModelChange );
        }
        public void UnregisterView( IView view )
        {
            this.ModelChangeEvent -= new ModelChangeDelegate( view.ModelChange );
        }
        public void RaiseModelChange(object sender, ModelChangeEventArgs e)
        {
            if (ModelChangeEvent != null)
                ModelChangeEvent(sender, e);
        }
    }

    public interface IView
    {
        void ModelChange(object sender, ModelChangeEventArgs e);
    }

    public class ModelChangeEventArgs
    {
        public int Number;

        private ModelChangeEventArgs() { }
        public ModelChangeEventArgs(int number)
        {
           Number = number;
        }

    }
}
