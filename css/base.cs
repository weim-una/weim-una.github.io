:root {
  --bg-grad: linear-gradient(135deg, #FFE5E5 0%, #FFF0F5 50%, #E8F5FF 100%);
  --pink: #FFB6C1; --pink-2:#FFD4E5; --hot:#FF69B4; --violet:#E0BBE4;
  --text:#4A4A4A; --accent:#D87093;
}

* { box-sizing: border-box; }
html, body { height: 100%; margin:0; padding:0; }
body {
  -webkit-text-size-adjust: 100%;
  font-family: 'Hiragino Sans','Noto Sans JP', system-ui, sans-serif;
  background: var(--bg-grad);
  display: flex; justify-content: center;
  padding: env(safe-area-inset-top) 16px calc(env(safe-area-inset-bottom) + 80px) 16px;
  color: var(--text); min-height: 100dvh; line-height: 1.65;
}

.container {
  width: min(100%, 920px);
  background: #fff;
  border-radius: 24px;
  box-shadow: 0 16px 48px rgba(255,182,193,0.28);
  overflow: clip;
}
.slide { display:none; padding: clamp(20px,4vw,60px); }
.slide.active { display:block; }

