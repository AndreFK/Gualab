::openscad.com -o p2.stl -D "part=\"Arm1\"" Original.scad
::pause
@echo off
setlocal enabledelayedexpansion

set  arrayline[0]=Cuff
set  arrayline[1]=Arm1
set  arrayline[2]=Arm2
set  arrayline[3]=Arm3
set  arrayline[4]=Arm4
set  arrayline[5]=Palm
set  arrayline[6]=PalmTop
set  arrayline[7]=PalmBolt
set  arrayline[8]=WristBoltNoCover
set  arrayline[9]=WristBoltWithCover
set  arrayline[10]=ElbowBolt
set  arrayline[11]=Tensioner
set  arrayline[12]=IndexFingerEnd
set  arrayline[13]=IndexFingerPhalanx
set  arrayline[14]=MiddleFingerEnd
set  arrayline[15]=MiddleFingerPhalanx
set  arrayline[16]=PinkyFingerEnd
set  arrayline[17]=PinkyFingerPhalanx
set  arrayline[18]=RingFingerEnd
set  arrayline[19]=RingFingerPhalanx
set  arrayline[20]=ThumbEnd
set  arrayline[21]=ThumbPhalanx
set  arrayline[22]=WhippleTreePrimary
set  arrayline[23]=WhippleTreeSecondary
set  arrayline[24]=LatchSlider
set  arrayline[25]=LatchPin
set  arrayline[26]=LatchTeeth
set  arrayline[27]=PencilHolderCover
set  arrayline[28]=Hinge4Knuckles
set  arrayline[29]=HingeIndexFinger
set  arrayline[30]=HingeMiddleFinger
set  arrayline[31]=HingePinkyFinger
set  arrayline[32]=HingeRingFinger
set  arrayline[33]=HingeThumb
set  arrayline[34]=HingeThumbKnuckle
set  arrayline[35]=LatchHinge
set  arrayline[36]=Thermoform1
set  arrayline[37]=Thermoform2
set  arrayline[38]=Thermoform3
set  arrayline[39]=Cover1
set  arrayline[40]=Cover2
set  arrayline[41]=Cover3
set  arrayline[42]=Cover4

cd ArchivosOriginales

echo ----------------Proceso de automatizacion de renderizacion de piezas----------------
echo.
echo.
echo.
::read it using a FOR /L statement
for /l %%f in (0,1,42) do (
echo Creando stl...
echo.
openscad.com -o "ArchivosModificados/ArchivosSTL/!arrayline[%%f]!.stl" -D "part=\"!arrayline[%%f]!\"" ArchivosModificados/Original.scad
echo archivo !arrayline[%%f]!.stl creado
echo.
)
pause