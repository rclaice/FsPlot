﻿module internal FsPlot.Browser

#if INTERACTIVE
#r """.\packages\Selenium.WebDriver.2.39.0\lib\net40\WebDriver.dll"""
#endif

open OpenQA.Selenium.Chrome
open System.Drawing
open System.IO
open System.Reflection

let private locateDriver() =
    let solutionDir =
        Assembly.GetExecutingAssembly().Location
        |> fun x -> x.Remove(x.IndexOf("""\packages\"""))
    Directory.GetFiles(solutionDir, "chromedriver.exe", SearchOption.AllDirectories).[0]
    |> Directory.GetParent
    |> fun x -> x.FullName

let private size = Size(700, 500)

let start() =
    let driver = new ChromeDriver(locateDriver())
    driver.Manage().Window.Size <- size
    driver