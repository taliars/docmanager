﻿using System;
using System.Threading.Tasks;

namespace DocManager.ViewModel
{
    public interface IDialogCoordinator
    {
        Func<string, string, bool, Task<bool>> Affirm { get; set; }
        Func<string, string, Task<string>> Input { get; set; }
        Func<string, string, string> Move { get; set; }
    }


    public sealed class DialogCoordinator: IDialogCoordinator
    {
        private static DialogCoordinator _instance;
        private static readonly object Padlock = new object();

        private DialogCoordinator()
        {
        }

        public static DialogCoordinator Instance 
        {
            get
            {
                lock (Padlock)
                {
                    return _instance ?? (_instance = new DialogCoordinator());
                }
            }
        }

        public Func<string, string, bool, Task<bool>> Affirm { get; set; }
        public Func<string, string, Task<string>> Input { get; set; }
        public Func<string, string, string> Move { get; set; }
    }
}
