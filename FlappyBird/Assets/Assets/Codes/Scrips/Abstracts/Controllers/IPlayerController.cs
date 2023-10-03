using Abstracts.Controllers;
using Abstracts.Inputs;
using Abstracts.SO;

namespace Abstracts.Controllers
{

    public interface IPlayerController : IEntityController
    {
        IPlayerInput PlayerInput { get; }
        IPlayerSO PlayerSO { get; }

    }

}