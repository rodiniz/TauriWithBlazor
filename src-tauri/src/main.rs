#![cfg_attr(
  all(not(debug_assertions), target_os = "windows"),
  windows_subsystem = "windows"
)]

use tauri::{ Menu, MenuItem, Submenu};

fn main() {

  let submenu = Submenu::new("File", Menu::new().add_native_item(MenuItem::Quit));
  let menu = Menu::new()
    .add_submenu(submenu);

  tauri::Builder::default()
    .menu(menu)
    .run(tauri::generate_context!())
    .expect("error while running tauri application");
}
