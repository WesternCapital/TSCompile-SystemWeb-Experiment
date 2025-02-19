# TS Compile with SystemWeb Experiment

Experiments to narrow in why our version of the typescript compiler ([Microsoft.TypeScript.MSBuild 2.4](https://www.nuget.org/packages/Microsoft.TypeScript.MSBuild/2.4.1)) wasn't working with [MSBuild.SDK.SystemWeb](https://github.com/CZEMacLeod/MSBuild.SDK.SystemWeb).

Turns out the issue was that older version of Microsoft.TypeScript.MSBuild [expect the tsconfig.json to have a build action of `None`](https://github.com/CZEMacLeod/MSBuild.SDK.SystemWeb/issues/86#issuecomment-2433469930)

