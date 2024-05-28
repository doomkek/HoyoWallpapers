# Genshin Wallpapers
This application make hosting of scrapped genshin/hsr web events piece of caek.<br>
![caek](https://github.com/doomkek/GenshinWallpapers/assets/141933494/6be667e9-d8db-4c56-9449-3971136c3199)

Why scrape web events? To use them as live wallpapers stupid nara!

## Usage 
- Download [release binary](https://github.com/doomkek/GenshinWallpapers/releases)
- Place it into a directory where you want to keep your wallpapers
- Run `launcher.exe`
- Download wallpaper from [download table](#wallpapers-download)
- Extract wallpaper into `wallpapers` folder
- Open `http://localhost:30000/{wallpaper_name}` to check if everything is working
	- wallpaper_name is a name of the folder where wallpaper is located (`wallpapers/e20240525preview`, `http://localhost:30000/e20240525preview`) 

## Customization
- You can pass different (optional) parameters thru URL 
- At the end of the URL add `?param=val&param2=val2` (`http://localhost:30000/e20240525preview?fps=45&wall=siggy`)
	- `fps` allow you to change render FPS (default is 60)
	- `wall` some wallpapers have multiple pages that can be used as wallpapers, allowed values can be found in the [download table](#wallpapers-download)
 - There is more advanced customizations possible like changing size and position of individual elements but its complicated so I might do a video instruction later if people need it
 - If you want to delete somebody from the wallpaper, you can find source image in images directory and just make it transparent (don't change resolution)

## Wallpapers Download
|Wallpaper|Download|Parameters|Preview|
| ------------- | ------------- | ------------- | ------------- |
|e20240525preview|[MEGA](https://mega.nz/folder/6LYTGa7R#0XswrjmKle7zvsfVnvODcg)|wall:[clori,siggy,sethos,furina,alhaitham]|![jqqztv1j](https://github.com/doomkek/GenshinWallpapers/assets/141933494/d71d4ddc-4402-4d30-98d1-ad524520162e)|
|e20240413preview|[MEGA](https://mega.nz/folder/TbxFSILa#Gh5AQ5ABpq0OgKzmx5_bHA)|wall:[boss,arle,lyney,baizhu,scara]|![mo14yfdr](https://github.com/doomkek/GenshinWallpapers/assets/141933494/0388873b-775a-4f89-8be5-3200c7b4a003)|
|e20230107preview|[MEGA](https://mega.nz/folder/HXwFyLYL#Q2MT0x06LjEu9HWSGStoRA)|wall:[alhaitham,yaoyao,hutao,yelan,xiao,ayaka(pretty),lisa,ganyu]|![c1us20fs](https://github.com/doomkek/GenshinWallpapers/assets/141933494/de696797-95c2-47d1-855a-e31ad14218c4) ![nvmli35m](https://github.com/doomkek/GenshinWallpapers/assets/141933494/7c46f42f-46ca-439f-8dbb-3b3700d32a32)|

## How to use as a wallpaper 
I'm using [Lively](https://www.rocksdanister.com/lively/), its open source and free, should work with any similar tool that allow you to use web page url as wallpaper.
Create new wallpaper and point URL to `http://localhost:30000/{wallpaper_nane}`

## Autorun
Application can create a scheduled task that would launch it in the background (no window, no tray icon, process only visible in task manager), **you need to launch it as administrator** and click "Create Schedule Task" <br>
You can create it manually (scheduled task or add shortcut to windows autostart dir), find guide online but don't forget to add `no-tray` as an argument and point `start in` directory where executable is located.


## >who asked?
**Q: Why filesize so big?** <br>
A: Application and all of it dependencies (even the runtime) was compiled into a single file so you don't have to install additional .NET runtime to run it

**Q: Why wallpaper size so big?** <br>
A: It is possible to trim all unnecesarry resources to save 100-150mb for each wallpaper but it takes too much time so I'm not doing it.

**Q: How to build from source?** <br>
- Download source code
- Download and install SDK https://dotnet.microsoft.com/en-us/download/dotnet/8.0
- Open directory with Launcher source code in cmd/terminal and execute `dotnet build` if you want to build into single file execute `dotnet publish -r win-x64 -p:PublishSingleFile=true --self-contained true` replace `win-x64` with apropriate runtime id https://learn.microsoft.com/en-us/dotnet/core/rid-catalog#known-rids (obviously its a windows application so only windows platform is supported but there is standalone ASP.NET project `GenshinWallpapers` that can be compiled for any other platform)

If you have more questions you can ask me at doomkek@tfwno.gf
