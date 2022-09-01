public interface ItauriHelper{

  Task<string> getTauriVersion();
  Task sendNotification(string message);
}
