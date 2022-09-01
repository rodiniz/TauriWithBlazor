using Microsoft.JSInterop;

public class TauriHelper: ItauriHelper{
 private readonly IJSRuntime JS;
 public TauriHelper(IJSRuntime JS){
  this.JS=JS;
 }

  public async Task<string> getTauriVersion()
  {
    return await JS.InvokeAsync<string>("getTauriVersion");
  }

  public async Task sendNotification(string message)
  {
      await JS.InvokeVoidAsync("sendNotification",message);
  }
}
