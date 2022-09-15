# Tauri with Blazor Wasm Template

- **Tauri** -https://tauri.app/
- **GitHub action** for cross-platform builds
- **Blazor webAssembly as the front-end Framework**  https://dotnet.microsoft.com/en-us/apps/aspnet/web-apps/blazor
- **Hot reload**
- **Another way of creating a multi platform application using Blazor**

## Dev instructions

### Get started

1. Install Node.js
2. Install Rust
3. Follow the [Tauri setup guide](https://tauri.app/v1/guides/getting-started/prerequisites)
4. Run `npm install`


### Commands
- `npm run tauri dev`: Start app in dev mode
- `npm run tauri build`: Build

### Release new version
1. Update `CHANGELOG.md`
2. Bump the version number in `src-tauri/Cargo.toml`
3. Run `cargo check` to update `Cargo.lock`
4. Create a git tag in the format `v#.#.#`
5. Add release notes to the generated GitHub release and publish it
