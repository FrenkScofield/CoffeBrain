namespace System
{
    internal class DataGridViewCellEventArgs
    {
        internal int RowIndex;
        private Action<object, Windows.Forms.DataGridViewCellEventArgs> btn_Add_Click;

        public DataGridViewCellEventArgs(Action<object, Windows.Forms.DataGridViewCellEventArgs> btn_Add_Click)
        {
            this.btn_Add_Click = btn_Add_Click;
        }
    }
}