# Philipp's Home Automations
## Removing accidentally committed secrets
```powershell
# 1. Get a list of exposed secrets in the git history
podman run -v ${PWD}:/path ghcr.io/gitleaks/gitleaks:latest git /path --report-path /path/findings.json

# 2. Build an expressions.txt file containing all replacements

# 3. After injecting the secrets via ExternalSecrets (or another way), run
git filter-repo --replace-text expressions.txt
```
