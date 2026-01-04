# 💬 C# OpenAI Chatbot (WinForms)

Bu proje, **C# Windows Forms** ortamında çalışan basit bir **OpenAI / OpenRouter tabanlı sohbet botu (chatbot)** uygulamasıdır.  
Kullanıcı, metin kutusuna yazdığı mesajları OpenAI API’sine gönderir ve yapay zekâdan yanıt alır.

---

## 🧠 Özellikler

- OpenRouter API (veya OpenAI API) üzerinden yanıt alır.  
- Gerçek zamanlı sohbet arayüzü.  
- Kullanıcı ve bot mesajlarını geçmişte gösterir.  
- “Enter” tuşu ile mesaj gönderme desteği.  
- Hata durumlarını kullanıcıya bildirir (örneğin bağlantı veya kota hataları).  
- Türkçe arayüz ve açıklamalar içerir.  

---

## 🧰 Kullanılan Teknolojiler

| Teknoloji | Açıklama |
|------------|-----------|
| **C# (.NET 6/7/8)** | Ana programlama dili |
| **Windows Forms** | Arayüz (UI) |
| **HttpClient** | API istekleri için |
| **Newtonsoft.Json** | JSON verilerini çözümlemek için |
| **OpenRouter API** | Chatbot motoru (alternatif olarak OpenAI API da kullanılabilir) |

---

## ⚙️ Kurulum

1. **Projeyi klonla veya indir:**
   ```bash
   git clone https://github.com/KULLANICI_ADIN/chatbot.git
   cd chatbot
