# プロジェクト運用方法
## プランナー
1. ★Git Bushをインストール
2. ★プロジェクトをgithubからクローン 
    - git clone プロジェクトのurl （わからんかったら調べて）
    
3. ★必要に応じてGithubのプロジェクト機能を使ってタスク管理（Trelloみたいなやつ）

## プログラマー
##### ※最新のプロジェクトをクローンしている前提
### 機能の実装
1. ★Issuesを書く
    - タイトルに実装項目を記入してチケット発行
    - 担当者をアサインする
    - Issuesを書けばgithubのProjectsにタスクを追加できるから便利
2. ★developからブランチを切る
    - developを最新の状態に更新してローカルにブランチを切る
    - ブランチの命名規則は原則{Issues番号.実装内容}を厳守！
    - git checkout -b ローカルに作成するブランチ名 origin/作成元のリモートのブランチ名 (やったことないけどこれでいけると思う)
        - 個人的にはvisual studioのチームエクスプローラーがおススメ。見やすくて使いやすい
3. ★ローカルで実装した内容をリモートにプッシュ
    - 変更内容をコミットする際はコミット分にIssues番号を記入すること。日本語でも英語でもそこはお任せ。
        - 例1） #1 takuto func wip
        - 例2） #1 たくと機能　改修中
    - リモートへプッシュ！
    - テストが必要ならここで依頼を投げる
4. ★一通り機能を実装してテストも大丈夫そうならdevelopへマージ
    - 自分の改修内容のpull requestを発行
    - 適当にレビューして終わったらgithub上でマージ作業（超簡単に出来る）
    - 担当のIsseusをクローズしておく。
    - 以上！これの繰り返し！
