README - PLEASE READ THIS BEFORE ATTEMPTING TO RUN THE SAMPLE APP
=====================

This sample is written in C#, targeting iOS & Android and using Visual Studio.  If you have a different setup, the sample may not run
properly.  

This is a Xamarin project to demonstrate the XAML capabilities to show case some use cases and re usable components using Xamarin Forms 


### To run the sample:

###### Compile the framework
1. Acquire the source from https://github.com/vijayandrodigithub/XamarinPOC.  
2. Before building the  code, make sure to restore all the packages associated to code.  Go to dependencies and packages section and right click restore.
3. Build the code and run it in iOS and Android simulators using MAC and Windows laptops accordingly. Note iOS app will run only in MAC.

###### Add your code 
1. To add your code please create a Tile under the class DashboardPage.cs if there is no Tile in your name. Else use the tile which has your name.
2. Once the Tile is added handle the switch case to navigate to your module or the POC. 
3. Follow the coding standards without fail 
4. Build and Run the application using Visual Studio 


### Using the XamarinPOC sample

This sample is a standalone application demonstrating a few simple use cases  or reusable components which are written using the XAML.  

### Additional notes:
- Currently, the samples contain no error-handling code whatsoever. The most likely sources of error are: Lets have a common code to handle the common errors or exceptions.
    - Bad network connection
    - Incorrect authentication
- Once you check out the code from Master please create a seperate branch for your POC 
- Do not to merge the code directly to Master 
- You will have to create a Pull request and the Team will review your code and merge it in to Master branch 
- Follow the same code structure and the pattern of code writing across all the samples 
- MVVM+ coding style to be followed while writing any code and adhere to the code architecture 




