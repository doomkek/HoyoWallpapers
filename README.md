# Genshin and HSR Wallpapers
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
- At the end of the URL add `?param=val&param2=val2` (`http://localhost:30000/e20240525preview?fps=45&wall=siggy&width=3000`)
	- `fps` allow you to change render FPS (default is 60)
	- `wall` some wallpapers have multiple pages that can be used as wallpapers, allowed values can be found in the [download table](#wallpapers-download)
 	- `width` and `height` (default is 2500x1080) to change wallpaper resolution, but **keep in mind that aspect ratio of the wallpaper will stay the same** (objects on the scene might go out of bounds)
 - There is more advanced customizations possible like changing size and position of individual elements but its complicated so I might do a video instruction later if people need it
 - If you want to delete somebody from the wallpaper, you can find source image in images directory and just make it transparent (don't change resolution)

## Wallpapers Download
|Wallpaper|Download|Parameters|Preview|
| ------------- | ------------- | ------------- | ------------- |
|e20240823mualani|[MEGA](https://mega.nz/folder/nWZnnDYK#APiIUB0m49JXvE-TdNVuhg)||![h5jx5jbx](https://github.com/user-attachments/assets/be33b08f-5eb6-4d6b-abe7-d14e22f0ae3b)|
|e20240817preview|[MEGA](https://mega.nz/folder/bWB1VDwT#etQaA2hsvdiy3GkrXlCzCw)|wall:[mualani,kinich,kachina,kazuha,raiden]|![cbvo4ba5](https://github.com/user-attachments/assets/85df5348-ecb7-4dc4-89ed-dd836b0bf9fb)|
|e20240801emilie|[MEGA](https://mega.nz/folder/aPYRxKQS#5sbPVfsCfSOa_eBZLjX8UA)||![0vw3gn2d](https://github.com/user-attachments/assets/b80ff69f-46ac-4258-9fd4-89f0667c2946)|
|e20240706preview|[MEGA](https://mega.nz/folder/zP42lCbL#bqbmzRC7TogiwMU4YySLqg)|wall:[emilie,nilou,navia,yelan,nilou_skin,kirara_skin]|![h3nw42wa](https://github.com/user-attachments/assets/228ecb2c-5126-45ba-9914-1b174c9e0674)|
|e20240620sigewinne|[MEGA](https://mega.nz/folder/CXIADYxD#pjPXkZqgs5FSPpYY4nuolQ)||![ikhyf2qs](https://github.com/doomkek/GenshinWallpapers/assets/141933494/9fbc8ca5-d301-4164-bae2-c128b716d08d)|
|e20240607version|[MEGA](https://mega.nz/folder/HSBQURjK#LwXxQ6oohI_CZI5FKz--hA)|wall:[firefly,jade,argenti,ruanmei]|![1my4zdl4](https://github.com/doomkek/GenshinWallpapers/assets/141933494/905c7bd1-496a-4444-8e86-f6e9948f3d75)|
|e20240531clorinde|[MEGA](https://mega.nz/folder/jSQQVL4A#3au8fkjF91mFzEF3CfiRYQ)||![udv0u0ov](https://github.com/doomkek/GenshinWallpapers/assets/141933494/e6fe01ce-0376-4d2c-bf1d-9d4cf1bf977a)|
|e20240525preview|[MEGA](https://mega.nz/folder/6LYTGa7R#0XswrjmKle7zvsfVnvODcg)|wall:[clori,siggy,sethos,furina,alhaitham,lynette]|![jqqztv1j](https://github.com/doomkek/GenshinWallpapers/assets/141933494/d71d4ddc-4402-4d30-98d1-ad524520162e)|
|e20240509robin|[MEGA](https://mega.nz/folder/KS5CjRRB#n4EWDXkZ-7DDdlNDvvMLHw)||![1yuq4gvr](https://github.com/doomkek/GenshinWallpapers/assets/141933494/c87c8633-5ef7-4d49-af4e-e69beaf96328)|
|e20240413preview|[MEGA](https://mega.nz/folder/TbxFSILa#Gh5AQ5ABpq0OgKzmx5_bHA)|wall:[boss,arle,lyney,baizhu,scara]|![mo14yfdr](https://github.com/doomkek/GenshinWallpapers/assets/141933494/0388873b-775a-4f89-8be5-3200c7b4a003)|
|e20240426version|[MEGA](https://mega.nz/folder/vLglhLRa#v1xNx4KtjI4GkRtDHVyl8Q)|wall:[robin,boothill,topass,fuxua]|![z53jx1xs](https://github.com/doomkek/GenshinWallpapers/assets/141933494/1eb30c5a-71ac-4593-b5a7-d6da8bac12fb)|
|e20231225melusine|[MEGA](https://mega.nz/folder/eaJxEIDS#CwO6ar6v_Yg4lpSfcTsN2g)||![nlmq4smj](https://github.com/doomkek/GenshinWallpapers/assets/141933494/3b07b9c4-aa80-49cd-bc85-5d61579f2049)|
|e20231028preview|[MEGA](https://mega.nz/folder/mXAlWYpb#2w1MKKRLTy3nKgp-uq4fPw)|wall:[furina,charlotte,ayato,baizhu,cyno]|![lkmxa3v0](https://github.com/doomkek/GenshinWallpapers/assets/141933494/fd87f4a0-5807-41af-bed8-09fd55fdd7a8)|
|e20231018version|[MEGA](https://mega.nz/folder/jf5XWAwD#r1OYxTg7BVwDtew2ou2nVQ)|wall:[fofo,argenti,hanya,silverass]|![lfn04qzl](https://github.com/doomkek/GenshinWallpapers/assets/141933494/8a52606b-c202-4e46-859e-e227b519bf28)|
|e20230107preview|[MEGA](https://mega.nz/folder/HXwFyLYL#Q2MT0x06LjEu9HWSGStoRA)|wall:[alhaitham,yaoyao,hutao,yelan,xiao,ayaka(pretty),lisa,ganyu]|![c1us20fs](https://github.com/doomkek/GenshinWallpapers/assets/141933494/de696797-95c2-47d1-855a-e31ad14218c4) ![nvmli35m](https://github.com/doomkek/GenshinWallpapers/assets/141933494/7c46f42f-46ca-439f-8dbb-3b3700d32a32)|
|e20220917prev|[MEGA](https://mega.nz/folder/bDJFGSLI#36hapHzdUkz5Lyd3Oz2ztg)|wall:[cyno,nilou,candace,venti,albedo,drake,asimon]|![v52gmmff](https://github.com/doomkek/GenshinWallpapers/assets/141933494/2071f9ee-0111-43b4-b00b-c3f07ee9fb7d)|
|e20220211bac|[MEGA](https://mega.nz/folder/iHIGwQBQ#lTotTZLKFY-BcucstjZk4w)||![vzpvehee](https://github.com/doomkek/GenshinWallpapers/assets/141933494/20d05bf6-9c77-47df-86c8-8dc4f4d514da)|
|e20220207previ|[MEGA](https://mega.nz/folder/PCxniYRQ#YN5My3lmG9qOoWqUiiQ9Dg)|wall:[boss,yae,raiden,koko]|![2ibwkl5q](https://github.com/doomkek/GenshinWallpapers/assets/141933494/80a1321d-1ca1-467b-9448-72f1d5094e99)|
|e20210820preview|[MEGA](https://mega.nz/folder/nLBRXapY#35dG4DeQf1VmSIz3qFThQg)||![q20ssqqv](https://github.com/doomkek/GenshinWallpapers/assets/141933494/aef8d69e-a2dc-4dfb-b488-d90b94496455)|



## How to use as a wallpaper 
I'm using [Lively](https://www.rocksdanister.com/lively/), its open source and free, should work with any similar tool that allow you to use web page url as wallpaper.
Create new wallpaper and point URL to `http://localhost:30000/{wallpaper_name}`

## Autorun
Application can create a scheduled task that would launch it in the background (no window, no tray icon, process only visible in task manager), **you need to launch it as administrator** and click "Create Schedule Task" <br>
You can create it manually (scheduled task or add shortcut to windows autostart dir), find guide online but don't forget to add `no-tray` as an argument and point `start in` directory where executable is located.


## >who asked?
**Q: Why filesize so big?** <br>
A: Application and all of it dependencies (even the runtime) was compiled into a single file so you don't have to install additional .NET runtime to run it

**Q: Why wallpaper size so big?** <br>
A: It is possible to trim all unnecesarry resources to save 10-20mb for each wallpaper but it takes too much time so I'm not doing it. <br>

**Q: How to build from source?** <br>
- Download source code
- Download and install SDK https://dotnet.microsoft.com/en-us/download/dotnet/8.0
- Open directory with Launcher source code in cmd/terminal and execute `dotnet build` if you want to build into single file execute `dotnet publish -r win-x64 -p:PublishSingleFile=true --self-contained true` replace `win-x64` with apropriate runtime id https://learn.microsoft.com/en-us/dotnet/core/rid-catalog#known-rids (obviously its a windows application so only windows platform is supported but there is standalone ASP.NET project `GenshinWallpapers` that can be compiled for any other platform)

If you have more questions you can ask me at doomkek@tfwno.gf
