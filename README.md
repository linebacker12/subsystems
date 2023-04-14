# EULYNX Live Subsystem Simulators

This repository contains .NET executables that simulate the behavior of the following EULYNX subsystems:

 - Light Signal (SCI-LS)
 - Point (SCI-P)
 - Train Detection System (SCI-TDS)
 
When paired with a *RaSTA Bridge*, they can be used to communicate with a EULYNX Digital Interlocking.

The SCI implementations are not complete, but implement only the most basic functionality.

## Manipulating the simulator state

Additional gRPC protocol specifications are in place for reading and manipulating the simulator state from within test scripts and train simulators.

You have 2 ways of consuming gRPC interfaces from this repo in order to use them in your code:

### 1. C# - Nuget Package:
1. Install our nuget package containing all Proto definitions: 
```
    dotnet add package EulynxLive.ProtobufInterfaces
```

2. Install GRPC nuget packages to be able to consume the proto file:
```
    dotnet add package Google.Protobuf
    dotnet add package Grpc.Tools
    dotnet add package Grpc.Net.Client
```

3. Add this property to the project reference of EulynxLive.ProtobufInterfaces:
```
    GeneratePathProperty="true"
```
Meaning that your reference to our package should look something like:
```
    <PackageReference Include="EulynxLive.ProtobufInterfaces" Version="x" GeneratePathProperty="true" />
```

4. Add a reference to the proto files on your ProtobufInterface package:
```
    <ItemGroup>
        <Protobuf Include="$(PkgEulynxLive_ProtobufInterfaces)/proto/**/*.proto" ProtoRoot="$(Pkg_EulynxLive_ProtobufInterfaces)" GrpcServices="Client" />
    </ItemGroup>
```


## Final notes:
Pull requests are welcome!
