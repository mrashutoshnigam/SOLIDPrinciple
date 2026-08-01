# Upgrade to .NET 10

## Preferences
- **Flow Mode**: Automatic
- **Target Framework**: net10.0

## Source Control
- **Source Branch**: master
- **Working Branch**: upgrade-dotnet-10
- **Commit Strategy**: After Each Task
- **Branch Sync**: Auto (Merge)

## Decisions
- Add a root `.gitignore` entry for `.github/upgrades/` so generated upgrade artifacts stay out of future commits.
