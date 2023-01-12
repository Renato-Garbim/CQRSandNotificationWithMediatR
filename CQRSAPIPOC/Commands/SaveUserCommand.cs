using CQRSAPIPOC.ViewModel;
using MediatR;

namespace CQRSAPIPOC.Commands
{
    public class SaveUserCommand : IRequest<MembershipCreateStatus>
    {
        public User UserData { get; set; }
        public int CreatedByUserId { get; set; }
        public string Message { get; set; }

    }
}
