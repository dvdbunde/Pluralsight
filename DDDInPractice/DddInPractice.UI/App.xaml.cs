﻿namespace DddInPractice.Logic.UI
{
    public partial class App
    {
        public App()
        {
            Initer.Init(@"Server=LBNL03569\SQLEXPRESS;Database=DddInPractice;Trusted_Connection=true");
        }
    }
}
