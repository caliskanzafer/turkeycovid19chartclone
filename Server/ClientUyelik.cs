using System;
using System.Collections.Generic;

namespace Server
{
    class ClientUyelik : ISubject
    {
        private IList<IObserver> observers;
        private String veriler;

        public ClientUyelik()
        {
            observers = new List<IObserver>();
            
        }
       
        public void notifyObservers()
        {
            foreach(var observer in observers)
            {
                observer.Update(veriler);
            }
        }
        public void changeStatus()
        {
            notifyObservers();
        }

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer); 
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }
        public void setVeriler(string yazi)
        {
            this.veriler = yazi;
            
        }
    }
}
