using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorTest.Shared.Models
{
    public class Todo
    {
        #region Properties

        public int Id { get; set; }

        public string Message { get; set; }

        public bool Completed { get; set; }

        #endregion
    }
}
