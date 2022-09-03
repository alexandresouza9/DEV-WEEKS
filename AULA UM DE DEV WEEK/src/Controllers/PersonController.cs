using Microsoft.AspNetCore.Mvc;

namespace src.Contollers;

[ApiController]
[Route("[Contoller]")]
public class PersonController : ControllerBase {
    
    [HttpGet]
    public string Hello(){
        return "Ola Souza";
    }

}
