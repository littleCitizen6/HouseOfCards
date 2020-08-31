using HouseOfCards.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HouseOfCards.Participent
{
    public abstract class Participant
    {
        protected List<IOperation> allowedOperations;
        public Participant()
        {
            allowedOperations = new List<IOperation>();
            LoadOperations();
            
            
        }

        private void LoadOperations()
        {
            var operationsType =  AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(a => a.GetTypes())
                .Where(type => typeof(IOperation).IsAssignableFrom(type) && type != typeof(IOperation)).ToList();
            operationsType.ForEach(type => allowedOperations.Add((IOperation)Activator.CreateInstance(type)));
        }

        public abstract void MakeTurn();

    }
}
