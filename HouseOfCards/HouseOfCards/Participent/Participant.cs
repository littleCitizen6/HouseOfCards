using HouseOfCards.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HouseOfCards.Participent
{
    public abstract class Participant
    {
        protected List<IOperation> _allowedOperations;
        public Participant()
        {
            _allowedOperations = LoadOperations();
            
            
        }

        private List<IOperation> LoadOperations()
        {
            List<IOperation> operations = new List<IOperation>();
            var operationsType =  AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(a => a.GetTypes())
                .Where(type => typeof(IOperation).IsAssignableFrom(type) && type != typeof(IOperation)).ToList();
            operationsType.ForEach(type => operations.Add((IOperation)Activator.CreateInstance(type)));
            return operations;
        }

        public abstract void MakeTurn();

    }
}
