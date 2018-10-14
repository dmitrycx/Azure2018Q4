## 2. Architecture

Schema shows a general approach with all infrastructure moved to a cloud.
some points here:

- Usage of CDN, Redis, AppInsights is discussible depends on needs - it's not free.
- PaaS approach is more preffered if we don't have specific need for IaaS.
- Public cloud approach is preffered. But we can use hybrid cloud if DB has some sensitive data.
- Availability sets or even availability zones might be used if needed.
- Traffic manager may be used for improved load balancing or because of some data access issues.

## 3. Create Infrastructure

Infrastructure is created
http://imageshack.com/a/img921/3259/1c6KdY.png
template and related file are in /ExportedTemplate-adventure-works-rg


## 4. Create Advanced infrastructure

Availability set is added
PowerShell script is created but needs to be fixed/updated


