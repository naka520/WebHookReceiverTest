using Microsoft.AspNetCore.Mvc;

namespace WebHookReceiverTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WebHookController : ControllerBase
    {
        [HttpPost]
        public IActionResult Receive([FromBody] dynamic payload)
        {
            // ここで受け取ったWebHookのペイロードを処理します
            // 例: ログに記録
            Console.WriteLine($"Received webhook: {payload}");

            // WebHookを正常に受信したことを示すHTTP 200 OKレスポンスを返します
            return Ok();
        }
    }
}
