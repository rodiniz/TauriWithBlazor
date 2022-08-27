const app=window.__TAURI__.app;
const dialog=window.__TAURI__.dialog;
const http=window.__TAURI__.http;
const notification=window.__TAURI__.notification;
window.getTauriVersion=async() =>{
  const tauriVersion = await app.getTauriVersion();
  return tauriVersion;
}

