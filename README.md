# Unity T4 Template Patch

[![openupm](https://img.shields.io/npm/v/com.xtaltools.unity-t4-patch?label=openupm&registry_uri=https://package.openupm.com)](https://openupm.com/packages/com.xtaltools.unity-t4-patch/)

Using T4 Template by Unity generated csproj.

## Install

### Package Manager

```manifest.json
{
    "dependencies": {
        "com.xtaltools.unity-t4-patch": "https://github.com/neptaco/UnityT4TemplatePatch.git?path=Packages/T4TemplatePatch"
    }
}
```

## Patching to Csproj

Automatically search for files with extension `.tt` and generate an ItemGroup tag.

Generated from `Assets/Scripts/Scripts/StringUtils.Generated.tt` as follows


```Assembly-Csharp.csproj:xml
  <ItemGroup>
    <Content Include="Assets\Scripts\StringUtils.Generated.tt">
      <Generator>TextTemplatingFileGenerator</Generator>
      <LastGenOutput>StringUtils.Generated.cs</LastGenOutput>
    </Content>
  </ItemGroup>
```  


### License

This library is under the MIT License.
