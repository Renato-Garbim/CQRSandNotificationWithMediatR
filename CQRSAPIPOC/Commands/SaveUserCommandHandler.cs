using CQRSAPIPOC.ViewModel;
using MediatR;

namespace CQRSAPIPOC.Commands
{
    public class SaveUserCommandHandler : IRequestHandler<SaveUserCommand, MembershipCreateStatus>
    {
        //implementar servico mockado

        public async Task<MembershipCreateStatus> Handle(SaveUserCommand request, CancellationToken cancellationToken)
        {
            return await Task.Run(() =>
            {
                try
                {
                    //_userService.SaveUser(command.UserData,
                    //           command.CreatedByUserId)

                    return new MembershipCreateStatus();

                }
                catch (Exception)
                {
                    throw;
                }
            }, cancellationToken);
        }
    }
}
