# NapelemEditor

## 🚀 Futtatás
### 🤠 feltételek
Electron futtatásához elengedhetetlen a Node
https://nodejs.org/en/download/

Minden máshoz elég a szimpla .NET 6.0 amit az IDE-vel együtt leszed


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

# 💻 Tech
Frontend: https://mudblazor.com/docs/overview 

Canvas: https://github.com/BlazorExtensions/Canvas



# Specs

# Épületek napelemes felületeinek tervezése
## irodalmazás
   > ## felhasználók:
   > ### admin: 
   > - napelem alaptipusok felvitele
   > - asd
   >
   >
   >  ### sima user:
   > - lefedés 
   > - lefedés eredményeként eldálló kalkuláció
   ## bemenet:
   >
   > -  napelem méretek (különbözö méretek, különbözö alak)
   >  - különbözö felületek (forma, nyilászárk, fal elötti objektumok figyelembevétele, etc.) >>> GUI
   ### tájolás
   >
   >  - időjárás 
   >  - nap beesési szöge 
   > - időszak
   # server oldalon:
   >  - mit fedtünk le? mennyit fedtünk le? mennyi a szabad terület? (lefedett terület nagysága) 
   > - panel elhelyezése lehetséges-e 
   > - számitási metodika kidolgozasa (viszonylag szabadon)