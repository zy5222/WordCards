# WordCards_s1131547

## 核心功能介紹

### 1. TSV 資料檔讀取
- **功能說明：** 讀取 Tab 分隔的單字資料檔（WordCards.txt），以 Unicode 編碼載入，確保音標正常顯示。
- **資料設計：** 每行格式為 `Word\tPhonogram\tSoundPath\tExplain`，透過 `WordItem` 建構子自動解析，多欄解釋欄位以 `\t` 分隔並合併為多行文字。

### 2. 自訂類別集合（WordItem / WordCollection）
- **功能說明：** `WordItem` 封裝單字、音標、音檔路徑、解釋四個屬性，並覆寫 `ToString()` 供 ListBox 直接顯示單字。`WordCollection` 繼承 `Collection<WordItem>`，提供 `LoadFromStringArray()` 批次載入資料。
- **資料設計：** 類別分離資料與 UI 邏輯，方便後續擴充與存檔操作。

### 3. 單字卡顯示與 GDI+ 介面
- **功能說明：** 左側 ListBox 顯示所有單字清單，右側顯示目前單字、音標與解釋，搭配自訂顏色配置呈現單字卡風格介面。
- **動態捲動：** 單字清單自動將選取項目保持在中間位置，提升瀏覽體驗。

### 4. Windows Media Player 發音
- **功能說明：** 整合 WMPLib 播放對應 MP3 音效檔，點擊清單或按下快速鍵即自動發音。
- **路徑驗證：** 播放前先確認音效檔是否存在，不存在時於狀態列顯示錯誤提示。

### 5. 自動播放功能
- **功能說明：** 點擊 Play 按鈕啟動 `Timer`（間隔 2000ms），自動依序切換並朗讀每個單字；再次點擊切換為 Stop 停止自動播放。

### 6. 編輯單字（frmEditWord）
- **功能說明：** 雙擊清單中的單字可開啟編輯視窗，修改單字、音標、音檔路徑與解釋後按下儲存，資料即時更新並自動寫回 WordCards.txt。
- **回傳機制：** 以 `DialogResult.Yes` 作為儲存確認訊號，主表單依此判斷是否執行存檔與重新播放。

---

## 防呆機制與設計

### 1. 單字檔不存在提示
- **問題解決：** 防止找不到 WordCards.txt 時程式直接崩潰。
- **判斷邏輯：** 表單載入時先以 `File.Exists()` 檢查檔案是否存在，不存在則彈出錯誤訊息並呼叫 `Application.Exit()` 安全結束。

### 2. 快速鍵操作
- **問題解決：** 提供鍵盤操作，不需滑鼠也能瀏覽單字。
- **判斷邏輯：** 表單設定 `KeyPreview = true`，於 `KeyPress` 事件中攔截 Enter（下一個）與 Space（重複朗讀），自動播放期間按鍵無效，避免衝突。

### 3. 音效路徑驗證
- **問題解決：** 防止音效檔遺失時程式拋出例外。
- **判斷邏輯：** `PlayWord()` 中以 `File.Exists(word.SoundPath)` 驗證路徑，檔案不存在時於狀態列顯示提示而非中斷程式。

### 4. 自動播放與手動操作互斥
- **問題解決：** 防止自動播放中途點擊清單造成計時器與手動操作衝突。
- **判斷邏輯：** `lstWordList_Click` 偵測到 `isPlay == true` 時自動觸發停止按鈕，確保狀態一致。

---

## 執行畫面

> 開啟程式後自動載入 WordCards.txt，左側顯示單字清單，右側顯示單字卡內容。

- 程式初始畫面（顯示第一個單字）

  <img width="580" height="360" alt="image" src="https://github.com/user-attachments/assets/fce23124-3134-4b4c-aec5-22a34a36c08c" />

- 雙擊單字開啟編輯視窗

  <img width="600" height="580" alt="image" src="https://github.com/user-attachments/assets/61be7774-6eb5-455d-8026-aad0e54b8da5" />

- 儲存後資料即時更新

  <img width="600" height="580" alt="image" src="https://github.com/user-attachments/assets/c1e4a986-3f50-4e6b-901b-295ec61b0ce8" />
  <img width="600" height="380" alt="image" src="https://github.com/user-attachments/assets/b0f1f502-4dcf-410b-8dea-fe66c02c62d4" />
