/** @type {import('tailwindcss').Config} */
module.exports = {
    content: [
        "App.razor",
        "./wwwroot/**/*.{razor,html,cshtml,cs}",
        "./Layout/**/*.{razor,html,cshtml,cs}",
        "./Pages/**/*.{razor,html,cshtml,cs}",
        "./Components/**/*.{razor,html,cshtml,cs}",
        "./Contributors/**/*.{razor,html,cshtml,cs}"
    ],
    darkMode: 'class',
    theme: {

        fontFamily: {
            'body': [
                'Geist Sans',
                'ui-sans-serif',
                'system-ui',
                '-apple-system',
                'system-ui',
                'Segoe UI',
                'Roboto',
                'Helvetica Neue',
                'Arial',
                'Noto Sans',
                'sans-serif',
                'Apple Color Emoji',
                'Segoe UI Emoji',
                'Segoe UI Symbol',
                'Noto Color Emoji'
            ],
            'sans': [
                'Geist Sans',
                'ui-sans-serif',
                'system-ui',
                '-apple-system',
                'system-ui',
                'Segoe UI',
                'Roboto',
                'Helvetica Neue',
                'Arial',
                'Noto Sans',
                'sans-serif',
                'Apple Color Emoji',
                'Segoe UI Emoji',
                'Segoe UI Symbol',
                'Noto Color Emoji'
            ],
            'mono': [
                'ui-monospace',
                'SFMono-Regular',
                'MesloLGL Nerd Font Mono',
                'Cascadia Mono',
                'Courier New'
            ]
        }
    }
}