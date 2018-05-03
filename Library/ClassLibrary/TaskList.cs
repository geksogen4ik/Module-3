using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibrary
{

    public class TaskList : IEnumerable<Task>
    {
        List<Task> tasksList = new List<Task>();

        public IEnumerator<Task> GetEnumerator()
        {
            return ((IEnumerable<Task>)tasksList).GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<Task>)tasksList).GetEnumerator();
        }


    }
}

    