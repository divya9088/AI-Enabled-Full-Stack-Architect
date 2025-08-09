Day 2 – Angular Standalone Fixes (Changed Files)

How to apply:
1) Unzip this archive inside: my-first-app/src/app/
   It will create/overwrite files in the correct folders.

2) Then run from my-first-app:
   npm install
   ng serve
   → Open http://localhost:4200

What’s included:
- app.ts             (standalone App with RouterOutlet + Welcome)
- app.html           (router-outlet + welcome)
- app.config.ts      (provideRouter wired with routes)
- app.routes.ts      (proper route objects for Home/About)
- home/home.ts       (standalone Home that imports AppChildComponent)
- home/home.html     (uses <app-child [messageFromParent]="...">)
- about/about.ts     (standalone About)
- welcome/welcome.ts (standalone Welcome)
- home/components/app-child/*  (new child component with @Input)

If you see path errors, ensure folders exist exactly as:
src/app/home/components/app-child/app-child.component.ts (etc.)
