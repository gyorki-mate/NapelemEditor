# NapelemEditor

## 🚀 Futtatás

Futtatás előtt telepítsd az ElectronNET.CLI-t

```bash
dotnet tool install ElectronNET.CLI -g
```

### Futtatás
```bash
electronize start /watch
```
## ⛏ Build


```bash
electronize build /target win /PublishReadyToRun true /PublishSingleFile true
```
### Note
> GitBash-ben a build nem működik, mert a `/target`-et a `C:/Program Files/Git/target`-ben keresi. Windows PowerShellben való futtatás megoldja a problémát.
