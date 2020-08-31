using HouseOfCards.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HouseOfCards.Participents
{
    public class BasicParticipent : Participant
    {
        private Random _random;
        public BasicParticipent(int id) : base(id) 
        {
            _allowedOperations = LoadOperations();
            _random = new Random();
        }
        public override void MakeTurn(GameManeger maneger)
        {
            int choice =_random.Next(_allowedOperations.Count);
            _allowedOperations[choice].Operate();
        }


        private List<IOperation> LoadOperations()
        {
            List<IOperation> operations = new List<IOperation>();
            var operationsType = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(a => a.GetTypes())
                .Where(type => typeof(IOperation).IsAssignableFrom(type) && type != typeof(IOperation)).ToList();
            operationsType.ForEach(type => operations.Add((IOperation)Activator.CreateInstance(type)));
            return operations;
        }
    }
}
