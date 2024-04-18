namespace ServerManagement.StateStore
{
    public class HalifaxOnlineServersStore : Observer
    {
        private int _numServersOnline;

        public int GetNumberServersOnline()
        {
            return _numServersOnline;
        }

        public void SetNumbersServersOnline(int number)
        {
            _numServersOnline = number;
            base.BroadcastStateChange();
        }

    }
}
