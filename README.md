Compilar y Ejecutar desde consola en Linux:

1.) Instalar "mono" utilizando los siguientes comandos:
     * sudo apt-key adv --keyserver hkp://keyserver.ubuntu.com:80 --recv-keys 3FA7E0328081BFF6A14DA29AA6A19B38D3D831EF
     * echo "deb http://download.mono-project.com/repo/debian wheezy main" | sudo tee /etc/apt/sources.list.d/mono-xamarin.list
     * sudo apt-get update
     * sudo apt-get install mono-complete
     
2.) Una vez instalado mono, se utiliza el siguiente comando para compilar:
    * mcs -out:my-gui-program.exe -r:System.Windows.Forms.dll -r:System.Drawing.dll *.cs
    
     (El *.cs se utiliza para compilar todos los archivos de tipo .cs)
    
3.) Una vez compilado, se ejecuta con el siguiente comando:
    * mono my-gui-program.exe


¡¡Lo ideal seria usar visual studio ya que lo hace todo mas facil!!




















ᵛᶦᵛᵃ ʷᶦⁿᵈᵒʷˢ
