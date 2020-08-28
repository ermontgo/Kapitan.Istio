function Generate-ApiClassesFromJson {
    param (
        [string]$filePath,
        [string]$group,
        [string]$version
    )

    kapitan-resgen -o $PSScriptRoot/src/Kapitan.Kubernetes.Istio -g $group -a $version $filePath -c $PSScriptRoot/crds.yaml
}

function Generate-ApiClassesFromDirectory {
    param (
        [string]$directory,
        [string]$group,
        [string]$version
    )

    $files = Get-ChildItem $directory
    foreach ($file in $files) {
        Generate-ApiClassesFromJson -filePath $file -group $group -version $version
    }
}

Generate-ApiClassesFromDirectory -directory "apis/authentication/v1alpha1" -group "authentication.istio.io" -version "v1alpha1"
Generate-ApiClassesFromDirectory -directory "apis/networking/v1alpha3" -group "networking.istio.io" -version "v1alpha3"
Generate-ApiClassesFromDirectory -directory "apis/networking/v1beta1" -group "networking.istio.io" -version "v1beta1"
Generate-ApiClassesFromDirectory -directory "apis/security/v1alpha1" -group "security.istio.io" -version "v1alpha1"
Generate-ApiClassesFromDirectory -directory "apis/security/v1beta1" -group "security.istio.io" -version "v1beta1"
