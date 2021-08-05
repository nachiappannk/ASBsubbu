# CREATING AND DEPLOYING AZURE FUNCTION THAT LISTENS TO AZURE SERVICE BUS QEUEUE

## Steps to create an Azure Function with ASBQ as trigger

```
func init LocalFunctionProj --worker-runtime dotnetisolated
cd LocalFunctionProj
func new 
```

choose servicebusqueuetrigger
and then enter the function name<funcctionname>

 Create an Azure Serivce bus queue under any resoruce group and note the connectionString 
  
now the code is generated, include "connectionString" as one of the key in local.settings.json and for value, enter the noted connectionString.
In <functionname>.cs, enter the name of the entered queue in place of "myqueue".  
