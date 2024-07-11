using Microsoft.AspNetCore.Mvc;

namespace webhookAutentique;

public class AutentiqueController : ControllerBase
{
    [HttpPost("/autentique")]
    public void AutentiqueWebhook([FromForm] WebhookPayload payload)
    {
        var teste = payload;
        return;
    }
}