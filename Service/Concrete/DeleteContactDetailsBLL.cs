using DAL;

namespace Service
{
    public class DeleteContactDetailsBLL : IDeleteContactDetailsBLL
    {
        private IDeleteContactDetailsDAL _deleteContactDetailsDAL;

        public DeleteContactDetailsBLL(IDeleteContactDetailsDAL deleteContactDetailsDAL)
        {
            _deleteContactDetailsDAL = deleteContactDetailsDAL;
        }

        public void deleteContactDetailsBLL(int id)
        {
            _deleteContactDetailsDAL.deleteContactDetailsDAL(id);
        }
    }
}